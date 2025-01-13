# Programa de Gestión de Estudiantes

Este es un programa de consola escrito en C# para la gestión de registros de estudiantes. Permite a los usuarios ingresar los datos de los estudiantes y guardarlos en un archivo de texto para su posterior consulta. Está diseñado para ser simple y fácil de usar.

## Funcionalidades

- **Añadir Estudiantes**: Los usuarios pueden ingresar información de un estudiante, incluyendo nombre, matrícula, carrera, materia y nota.
- **Almacenamiento en Archivo**: El programa guarda los datos de los estudiantes en un archivo de texto local (`Estudiante.txt`) para garantizar la persistencia de los datos.
- **Interfaz Fácil de Usar**: Un menú sencillo guía a los usuarios a través del proceso de ingreso de información.

## Estructura del Programa

El programa se compone de tres clases principales:

### 1. Program
Es el punto de entrada del programa. Contiene el bucle principal que ofrece al usuario la opción de añadir estudiantes o salir del programa.

### 2. Alumnos
Esta clase define el modelo para los estudiantes con las siguientes propiedades:
- Name: Nombre del estudiante.
- Matricula: Número de matrícula del estudiante.
- Carrera: Carrera que estudia el estudiante.
- Materia: Materia en la que está inscrito.
- Nota: Nota obtenida en la materia.

### 3. Funcionalidades
Contiene la lógica principal del programa:
- **AddUser**: Solicita al usuario los datos del estudiante y los almacena en una instancia de la clase Alumnos.
- **BlocNotas**: Guarda la información del estudiante en el archivo Estudiante.txt.

## Uso del Programa

1. Al ejecutar el programa, aparecerá un menú donde se le preguntará si desea añadir un estudiante.
2. Si selecciona "Sí", se le pedirá ingresar los datos del estudiante:
   - Nombre
   - Matrícula
   - Carrera
   - Materia
   - Nota
3. Los datos ingresados se guardarán en el archivo Estudiante.txt.
4. Puede repetir el proceso para añadir más estudiantes o salir del programa.


