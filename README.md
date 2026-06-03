# 🧮 CalculadoraWPF V2.0

Aplicación de escritorio desarrollada en **C# + WPF (.NET 10)** enfocada en practicar:

- Programación Orientada a Objetos
- Separación de responsabilidades
- Arquitectura básica
- Manejo de eventos
- Interfaces gráficas con XAML
- Validaciones y excepciones

---

# 🚀 Características

## ✅ Operaciones Básicas

Permite resolver expresiones matemáticas completas:

1+2*3  
(5+2)/2  
10-4*2  

Usando:

DataTable().Compute()

---

## ✅ Potencias

Cálculo de potencias usando:

Math.Pow()

Ejemplo:

2^5 = 32

---

## ✅ Raíz Cuadrada

Cálculo de raíces cuadradas con validación de negativos.

Ejemplo:

√25 = 5

---

## ✅ Calculadora IMC

Incluye:
- Nombre
- Fecha de nacimiento
- Cálculo automático de edad
- Peso
- Altura
- Resultado IMC
- Categoría física

---

# 🧠 Tecnologías usadas

- C#
- .NET 10
- WPF
- XAML
- OOP
- Event Handlers
- DataTable.Compute()

---
```

# 📂 Estructura del Proyecto

CalculadoraWPF/
│
├── Models/
│   └── Usuario.cs
│
├── Services/
│   ├── CalculadoraBasica.cs
│   ├── OperacionesAvanzadas.cs
│   └── IMCService.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
└── App.xaml
```
---

# 🖼️ Interfaz gráfica

La aplicación fue migrada desde consola hacia una interfaz WPF usando:
- TextBox
- Buttons
- TextBlocks
- DatePicker
- StackPanels
- Borders
- ScrollViewer

---

# ⚙️ Arquitectura

El proyecto separa:
- lógica de negocio
- interfaz gráfica
- modelos
- servicios

Esto facilita:
- mantenimiento
- escalabilidad
- reutilización de código

---

# 🔥 Conceptos Practicados

## Programación Orientada a Objetos

- Clases
- Métodos
- Encapsulación
- Responsabilidad única

---

## WPF

- XAML
- Eventos (Click)
- Controles visuales
- Namespaces
- InitializeComponent()

---

## Manejo de Errores

Uso de:

try/catch

y validaciones personalizadas.

---

# ▶️ Ejecutar el Proyecto

## Requisitos

- .NET 10 SDK
- Windows
- Workload Desktop

Verificar instalación:

dotnet --version

---

## Ejecutar

dotnet run

---

# 📌 Aprendizajes

Durante el desarrollo se practicó:
- migración de consola a WPF
- conexión entre XAML y C#
- solución de errores de namespaces
- problemas de IntelliSense en VS Code
- generación automática de componentes WPF

---

# 🧪 Estado del Proyecto

Versión: V2.0  
Estado: Funcional

---

# 🚀 Próximas mejoras

- Historial de operaciones
- Temas visuales
- Validaciones más avanzadas
- MVVM
- Persistencia JSON
- Animaciones
- Calculadora científica
- Diseño responsive
- Navegación entre ventanas

---

# 😭 Nota de Desarrollo

VS Code + WPF puede presentar errores visuales de IntelliSense aunque el proyecto compile correctamente.

En muchos casos se solucionan eliminando:

bin/  
obj/

y reiniciando el C# Dev Kit.
