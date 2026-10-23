using EventoPresupuestado.Dto;
using EventoPresupuestado.RolControl.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.RolControl

{
    public class AdminMoodController
    {
        private readonly IConfigRepository _repository;

        public AdminMoodController()
        {
            _repository = new AdminMoodRepositoryJSON();
        }


        public bool isPrimerUso()
        {
            AdminMood config = _repository.ObtenerConfiguracion();
            return config == null || string.IsNullOrEmpty(config.PasswordHash);
        }

        public bool IsAdminActivo()
        {
            return SesionActual.isAdminActivo;
        }

        public ResultDto ValidarLoginAdmin(string passwordIngresada)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(passwordIngresada))
                {
                    return ResultDto.Warning("Debe ingresar la contraseña de administrador.");
                }

                AdminMood config = _repository.ObtenerConfiguracion();
                if (config == null || string.IsNullOrEmpty(config.PasswordHash))
                {
                    return ResultDto.Warning("No hay credenciales configuradas en el sistema.");
                }

                bool esValida = SecurityHelper.VerifyPassword(passwordIngresada, config.PasswordHash);

                if (esValida)
                {
                    SesionActual.isAdminActivo = true;

                    return ResultDto.Success("Modo Administrador activado con éxito.");
                }
                else
                {
                    return ResultDto.Warning("Contraseña incorrecta.");
                }
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("Error crítico al validar el acceso: " + ex.Message);
            }
        }

        public ResultDto RegistrarAdminInicial(AdminDto dto)
        {
            try
            {
                if (!isPrimerUso())
                {
                    return ResultDto.Warning("El administrador ya se encuentra registrado en el sistema.");
                }

                if (string.IsNullOrWhiteSpace(dto.passwordNew) || dto.passwordNew != dto.passwordNewConfirm)
                {
                    return ResultDto.Warning("La nueva contraseña y su confirmación no coinciden.");
                }

                if (string.IsNullOrWhiteSpace(dto.Email))
                {
                    return ResultDto.Warning("Debe ingresar un correo electrónico de recuperación.");
                }

                string nuevoHash = SecurityHelper.HashPassword(dto.passwordNew);
                AdminMood adminModel = new AdminMood(nuevoHash, dto.Email);

                _repository.GuardarConfiguracion(adminModel);

                return ResultDto.Success("¡Usuario Administrador registrado con éxito! Ya puede operar en el sistema.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo registrar el administrador debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto ChangePassword(AdminDto dto)
        {
            try
            {
                AdminMood configActual = _repository.ObtenerConfiguracion();

                if (configActual == null || string.IsNullOrEmpty(configActual.PasswordHash))
                {
                    return ResultDto.Warning("No hay credenciales registradas para actualizar.");
                }

                if (string.IsNullOrWhiteSpace(dto.passwordActual))
                {
                    return ResultDto.Warning("Debe ingresar la contraseña actual para realizar modificaciones.");
                }

                if (!SecurityHelper.VerifyPassword(dto.passwordActual, configActual.PasswordHash))
                {
                    return ResultDto.Warning("La contraseña actual es incorrecta.");
                }

                if (string.IsNullOrWhiteSpace(dto.passwordNew) || dto.passwordNew != dto.passwordNewConfirm)
                {
                    return ResultDto.Warning("La nueva contraseña y su confirmación no coinciden.");
                }

                string nuevoHash = SecurityHelper.HashPassword(dto.passwordNew);

                AdminMood adminModel = new AdminMood(nuevoHash, configActual.Email);

                _repository.GuardarConfiguracion(adminModel);

                return ResultDto.Success("La contraseña de administrador fue actualizada correctamente.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo actualizar la contraseña debido a un error del sistema: " + ex.Message);
            }
        }

        public ResultDto UpdateEmail(string nuevoEmail)
        {
            try
            {
                AdminMood configActual = _repository.ObtenerConfiguracion();

                if (configActual == null || string.IsNullOrEmpty(configActual.PasswordHash))
                {
                    return ResultDto.Warning("Debe registrar la contraseña inicial del sistema antes de configurar el correo.");
                }

                AdminMood modeloActualizado = new AdminMood(configActual.PasswordHash, nuevoEmail);

                _repository.GuardarConfiguracion(modeloActualizado);

                return ResultDto.Success("El correo electrónico de recuperación se actualizó con éxito.");
            }
            catch (ArgumentException ex)
            {
                return ResultDto.Warning(ex.Message);
            }
            catch (Exception ex)
            {
                return ResultDto.Fatal("No se pudo actualizar el correo electrónico debido a un error del sistema: " + ex.Message);
            }

        }
    }
}
    
