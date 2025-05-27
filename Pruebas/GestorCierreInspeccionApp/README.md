# Gestor de Cierre de Inspección

Este proyecto es una aplicación de gestión que permite a los responsables de inspecciones cerrar órdenes de inspección para estaciones sismológicas. Utiliza un conjunto de clases que simulan una base de datos con objetos de ejemplo, facilitando la interacción y el manejo de datos.

## Estructura del Proyecto

El proyecto está organizado en varias carpetas que contienen diferentes componentes de la aplicación:

- **src/Controladores**: Contiene la clase `GestorCierreInspeccion`, que gestiona el proceso de cierre de órdenes de inspección.
- **src/DatosHardcodeados**: Incluye la clase `DatosHardcodeados`, que simula una base de datos con datos predefinidos.
- **src/Entidades**: Contiene las definiciones de las clases que representan los diferentes elementos del sistema, como empleados, estados, estaciones sismológicas, órdenes de inspección, roles, sesiones, sismógrafos y usuarios.
- **src/Program.cs**: Este archivo es el punto de entrada de la aplicación, donde se inicializa y ejecuta la lógica principal.

## Instrucciones de Configuración

1. Clona este repositorio en tu máquina local.
2. Abre el proyecto en tu entorno de desarrollo preferido.
3. Asegúrate de tener instalado .NET SDK para compilar y ejecutar la aplicación.
4. Ejecuta el proyecto desde la línea de comandos o desde tu IDE.

## Uso

Una vez que la aplicación esté en funcionamiento, los responsables de inspecciones podrán:

- Iniciar sesión en el sistema.
- Seleccionar órdenes de inspección que estén completamente realizadas.
- Cerrar órdenes de inspección, ingresando observaciones y motivos para el estado "Fuera de Servicio" del sismógrafo asociado.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas mejorar el proyecto, por favor abre un issue o envía un pull request.

## Licencia

Este proyecto está bajo la Licencia MIT.