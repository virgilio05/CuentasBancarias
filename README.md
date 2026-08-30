# INF512-Unidad1-POO
## Proyecto de Programación Orientada a Objetos - Unidad 1

### 📌 Descripción del Proyecto

Este proyecto implementa un **Sistema de Gestión de Cuentas Bancarias** aplicando los conceptos fundamentales de Programación Orientada a Objetos (POO) vistos en la Unidad 1.

### 🎯 Objetivos

- Aplicar encapsulación mediante atributos privados y métodos públicos
- Implementar abstracción ocultando la complejidad interna
- Demostrar estado y comportamiento de objetos
- Validar datos antes de modificar el estado

### 📋 Requisitos Implementados

✅ **Actividad 1: Diseño de la clase CuentaBancaria**
- Atributos privados (nombreTitular, numeroCuenta, saldo)
- Constructor que inicializa todos los atributos
- Método Depositar(decimal monto) con validación
- Método Retirar(decimal monto) con validación de saldo
- Método MostrarDetalles() para visualizar información

✅ **Actividad 2: Programa Principal**
- Creación de al menos dos objetos CuentaBancaria
- Mostrar datos iniciales
- Realizar depósito y retiro
- Mostrar datos finales

✅ **Actividad 3: Evidencias Técnicas**
- Compilación exitosa
- Ejecución del programa
- Funcionamiento de operaciones bancarias

### 📁 Estructura del Proyecto

```
CuentasBancarias/
├── CuentaBancaria.cs       # Clase principal con encapsulación
├── Program.cs              # Programa principal con menú
├── App.config              # Configuración de aplicación
└── bin/
	└── Debug/
		└── CuentasBancarias.exe  # Ejecutable compilado
```

### 💻 Tecnologías Utilizadas

- Lenguaje: C#
- Framework: .NET Framework 4.7.2
- IDE: Visual Studio 2026

### 🚀 Cómo Ejecutar

1. Abre el archivo `CuentasBancarias.slnx` en Visual Studio
2. Presiona **F5** o selecciona "Iniciar depuración"
3. El programa mostrará automáticamente:
   - Datos iniciales de dos cuentas
   - Operaciones de depósito y retiro
   - Saldos finales actualizados

### 📚 Conceptos de POO Implementados

#### Encapsulamiento
- Los atributos `nombreTitular`, `numeroCuenta` y `saldo` son `private`
- Solo se accede a través de métodos públicos validados
- Protege la integridad de los datos

#### Abstracción
- Los métodos `Depositar()` y `Retirar()` ocultan la complejidad interna
- El usuario solo llama al método, sin conocer los detalles de la implementación
- Las validaciones se realizan internamente

#### Estado y Comportamiento
- **Estado:** El saldo actual, nombre del titular, número de cuenta
- **Comportamiento:** Las operaciones que modifica el estado (depositar, retirar)

### ✅ Validaciones Implementadas

| Operación | Validación |
|-----------|-----------|
| Depositar | El monto debe ser > 0 |
| Retirar | El monto debe ser > 0 y ≤ saldo actual |
| Saldo | No puede ser negativo |

### 📖 Ejemplo de Uso

```csharp
// Crear una cuenta
CuentaBancaria cuenta = new CuentaBancaria("Juan Pérez", "100001", 5000.00m);

// Mostrar detalles
cuenta.MostrarDetalles();

// Realizar depósito
cuenta.Depositar(2500.00m);

// Realizar retiro
cuenta.Retirar(1000.00m);

// Ver detalles actualizados
cuenta.MostrarDetalles();
```

### 📊 Resultados Esperados

```
Titular:        Juan Pérez
Número de Cuenta: 100001
Saldo Actual:   $7500.00
(después de depositar $2500 y retirar $1000)
```

### 👨‍💻 Autor

Estudiante de Informática 512
Año: 2026

### 📝 Licencia

Este proyecto es de propósito educativo.

### 🔗 Control de Versiones

Este repositorio utiliza Git para el control de versiones con commits descriptivos que documentan cada fase del desarrollo.
