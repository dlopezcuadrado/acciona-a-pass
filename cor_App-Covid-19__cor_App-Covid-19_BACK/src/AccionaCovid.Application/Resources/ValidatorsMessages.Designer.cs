﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccionaCovid.Application.Resources {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ValidatorsMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidatorsMessages() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AccionaCovid.Application.Resources.ValidatorsMessages", typeof(ValidatorsMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Conflicto con otro empleado del sistema.
        /// </summary>
        internal static string EMPLOYEE_CONFLICT {
            get {
                return ResourceManager.GetString("EMPLOYEE_CONFLICT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Estado de pasaporte prohibido para una transicion generada por un perfil RRHH.
        /// </summary>
        internal static string FORBIDDEN_PASSPORT_FOR_HR {
            get {
                return ResourceManager.GetString("FORBIDDEN_PASSPORT_FOR_HR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a {0} no encontrado.
        /// </summary>
        internal static string NOT_FOUND {
            get {
                return ResourceManager.GetString("NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El estado del empleado ha sido modificado, pero no ha sido posible enviar una alerta a su responsable ya que este empelado no tiene responsable configurado.
        /// </summary>
        internal static string PANIC_ALERT_NO_RESPONSABLE {
            get {
                return ResourceManager.GetString("PANIC_ALERT_NO_RESPONSABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El empleado {0} ha pulsado el botón de &apos;Me encuentro mal&apos;..
        /// </summary>
        internal static string PANIC_COMMIT_ALERT {
            get {
                return ResourceManager.GetString("PANIC_COMMIT_ALERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Empleado con posibles síntomas.
        /// </summary>
        internal static string PANIC_TITLE_ALERT {
            get {
                return ResourceManager.GetString("PANIC_TITLE_ALERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El valor del campo {0} es obligatorio.
        /// </summary>
        internal static string VALUE_CANNOT_BE_NULL_OR_EMPTY {
            get {
                return ResourceManager.GetString("VALUE_CANNOT_BE_NULL_OR_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El valor del campo {0} no puede ser cero o menor que cero.
        /// </summary>
        internal static string VALUE_CANNOT_BE_ZERO_OR_NEGATIVE {
            get {
                return ResourceManager.GetString("VALUE_CANNOT_BE_ZERO_OR_NEGATIVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La longitud del valor del campo {0} no puede ser menor de 3 caracteres.
        /// </summary>
        internal static string VALUE_LESS_3_CHARACTERS {
            get {
                return ResourceManager.GetString("VALUE_LESS_3_CHARACTERS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El valor del campo {0} tiene un formato incorrecto.
        /// </summary>
        internal static string VALUE_WRONG_FORMAT {
            get {
                return ResourceManager.GetString("VALUE_WRONG_FORMAT", resourceCulture);
            }
        }
    }
}
