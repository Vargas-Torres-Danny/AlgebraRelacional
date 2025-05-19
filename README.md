# Álgebra Relacional - ASP.NET Web Forms

Este proyecto es una aplicación web construida con ASP.NET Web Forms que permite ejecutar consultas representativas de operaciones unarias y binarias del álgebra relacional sobre una base de datos de ventas (`BDVentas`).

---

## Características

- Consulta de datos mediante:
  - **Operaciones unarias**:
    - Selección (σ)
    - Proyección (π)
    - Renombramiento (ρ)
  - **Operaciones binarias**:
    - Unión (∪)
    - Diferencia (−)
    - Producto cartesiano (×)
- Interfaz mediante botones por consulta
- Visualización de resultados en un `GridView`

---

## Requisitos

- Visual Studio 2019 o superior
- SQL Server (Express o completo)
- .NET Framework 4.x
- Base de datos `BDVentas` con las tablas:
  - `TCliente`
  - `TProducto`
  - `TVendedor`
  - `TBoleta`
  - `TCategoria`

---

## Configuración

1. Clona o descarga este repositorio.
2. Asegúrate de tener la base de datos `BDVentas` creada con sus tablas y algunos datos de prueba.
3. Modifica la cadena de conexión en `WebForm1.aspx.cs` si tu servidor no es `localhost`:

## Uso

Una vez que ejecutes la aplicación:

1. Se mostrará una página web con botones desde **Consulta 1** hasta **Consulta 18**.
2. Cada botón corresponde a una operación del álgebra relacional.
3. Al hacer clic en un botón, se ejecuta la consulta SQL correspondiente y el resultado se muestra en un `GridView` en pantalla.
4. Puedes interactuar libremente para visualizar diferentes resultados.

---

## Operaciones incluidas

| Tipo de operación      | Consultas        | Descripción                                           |
|------------------------|------------------|-------------------------------------------------------|
| Selección (σ)          | 1, 4, 7          | Filtra filas según condiciones (`WHERE`)             |
| Proyección (π)         | 2, 5, 8          | Selecciona columnas específicas (`SELECT columna`)   |
| Renombramiento (ρ)     | 3, 6, 9          | Renombra columnas con alias (`AS`)                   |
| Unión (∪)              | 10, 11, 12       | Combina filas únicas de dos consultas (`UNION`)      |
| Diferencia (−)         | 13, 14, 15       | Muestra resultados que están en una tabla y no en otra (`EXCEPT`) |
| Producto cartesiano (×)| 16, 17, 18       | Combina todas las filas posibles entre dos tablas (`CROSS JOIN`) |

---

## Autores

- Nombres: Vargas Torres Danny Ruben, Gamarra Laura Edgar Mauricio, Chevarria Revollar Jose Andrei, Yabar Nieto Ricardo Fabio
- Curso: Modelado de Base de datos
- Taller 3.1: Algebra Relacional
- Fecha:  19 de Mayo del 2025

---

## licencia
Este proyecto es de uso educativo. Puedes utilizarlo, modificarlo y distribuirlo con fines académicos.
