# Gestor de Alumnos -- WinForms

**Autor:** Valentino Pizzicatti\
**Legajo:** B00118483-T1

------------------------------------------------------------------------

## 📌 Descripción del Proyecto

Aplicación desarrollada en **C# (.NET 8, WinForms)** que permite
gestionar archivos de alumnos en diferentes formatos (TXT, CSV, JSON,
XML).\
Incluye funciones de conversión entre formatos, carga y edición de
datos, y generación de reportes con corte de control por Apellido.

------------------------------------------------------------------------

## 🖥️ Requisitos del Sistema

-   Windows 10/11\
-   .NET 8 SDK\
-   Visual Studio 2022 o superior\
-   Extensiones de desarrollo para Windows Forms en C#

------------------------------------------------------------------------

## ⚙️ Instrucciones de Compilación

1.  Clonar o descargar el repositorio del proyecto.\
2.  Abrir la solución `.sln` en Visual Studio.\
3.  Seleccionar la configuración **Debug** o **Release**.\
4.  Ejecutar con **Ctrl + F5** o compilar desde *Build → Build
    Solution*.

------------------------------------------------------------------------

## ▶️ Instrucciones de Uso Básico

1.  **Cargar archivo:**
    -   Seleccionar un archivo de alumnos en cualquier formato
        soportado.\
2.  **Visualizar datos:**
    -   Los alumnos cargados se muestran en un `DataGridView`.\
3.  **Convertir archivo:**
    -   Elegir formato de destino (TXT, CSV, JSON, XML) y guardar.\
4.  **Generar reporte:**
    -   Crear un reporte agrupado por Apellido, mostrarlo en pantalla y
        guardarlo como TXT.

------------------------------------------------------------------------

## ⚠️ Problemas Conocidos

-   Algunos archivos mal formateados pueden generar errores de lectura.\
-   El sistema no valida campos de email o teléfono en profundidad.

------------------------------------------------------------------------

## ⭐ Extras Implementados

-   Reporte con subtotales por apellido.\
-   Agrupación y ordenamiento automático mediante LINQ.\
-   Interfaz WinForms amigable con selección guiada de archivos.
