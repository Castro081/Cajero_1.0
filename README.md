# Proyecto de Cajero Automático

## Descripción del Proyecto

Este proyecto tiene como objetivo desarrollar un Cajero Automático para una empresa, con el fin de brindar dinero en efectivo a los empleados de su Área Administrativa. El proyecto permite al estudiante resolver problemas de programación y manejar el almacenamiento de información en archivos de texto.

## Objetivos

- **Desarrollar habilidades de resolución de problemas** mediante herramientas de programación.
- **Organizar ideas y pensamientos** para implementar soluciones eficientes.
- **Implementar un sistema de almacenamiento** de información en archivos de texto para llevar el control de las actividades del cajero.

## Estructura del Proyecto

El proyecto está organizado de la siguiente manera:

- **/Cajero**: Contiene el código fuente del proyecto.
  - **/Modelos**: Clases que representan los datos y la lógica del negocio.
  - **/Vistas**: Interfaz gráfica del usuario y del administrador (GUI).
  - **/Datos**: Archivos tipo txt donde se almacenas los datos del cajero.
  - **/Resources**: Archivos de configuración y otros recursos necesarios.
  - **/Documentación**: Documentación del proyecto.

El Cajero Automático se divide en dos áreas principales:

1. **Área Administrativa**:
   - **Creación de usuarios**: Registrar nuevos usuarios con datos como nombre, número de tarjeta, PIN, saldo actual, y límite de retiro diario.
   - **Inicializar cajero**: Inicializar el cajero con la cantidad de billetes disponibles al inicio del día, con un máximo de Q. 10,000.00.
   - **Agregar efectivo**: Añadir más billetes al cajero, con un máximo de Q. 30,000.00, solo después de la inicialización.
   - **Modificar número de tarjeta**: Cambiar el número de tarjeta de un usuario, manteniendo un récord para respetar el límite diario de retiros.
   - **Modificar límite**: Cambiar el monto máximo de retiro diario de un usuario.
   - **Consulta de usuario**: Ver detalles como el monto máximo disponible, saldo actual, cantidad retirada, y último acceso.
   - **Control de usuarios**: Revisar el total retirado por todos los usuarios, promedio de depósitos, usuarios que han cambiado su PIN, y el último usuario que accedió al cajero.

2. **Área de Usuarios**:
   - **Cambiar PIN**: Modificar el PIN actual después de ingresar tarjeta y PIN correctos.
   - **Retiros**: Retirar dinero ingresando tarjeta, PIN y token, y especificar la cantidad y desglose de denominaciones.
   - **Depósito**: Realizar depósitos detallando el desglose de denominaciones.
   - **Ver últimas transacciones**: Mostrar las últimas 5 transacciones del usuario, incluyendo fecha, hora, monto, y tipo de transacción.
   - **Ver saldo**: Consultar el monto máximo disponible para retiro y el saldo restante del día.



## Requisitos
- **Lenguaje de Programación**: C#...
- **Sistema Operativo**: Windows.
- **Software Necesario**: 
    - [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/)
    - [.NET SDK](https://dotnet.microsoft.com/download) (versión 6.0 o superior)
    - Git (opcional, para control de versiones).
