# Cómo ejecutar el proyecto Blazor Web App

Sigue los pasos a continuación para configurar y ejecutar correctamente este proyecto desarrollado con **Blazor Web App**, **.NET Core 8**, **SQL Server** y **Entity Framework**.

---

## 1. Clona el repositorio

Ejecuta el siguiente comando en tu terminal para clonar el repositorio:

```bash
git clone <url-del-repositorio>
```

Luego, accede al directorio del proyecto:

```bash
cd <nombre-del-proyecto>
```

---

## 2. Configura la base de datos

El proyecto incluye un archivo de configuración llamado `appsettings.json`. Abre este archivo y verifica o edita la cadena de conexión para que apunte a tu instancia de SQL Server:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=MiBaseDeDatos;User Id=usuario;Password=contraseña;"
}
```

### Si la base de datos no existe:
1. Abre la terminal o el **Package Manager Console** en Visual Studio.
2. Aplica las migraciones para crear la base de datos ejecutando:

```bash
dotnet ef database update
```

#### (Opcional) Si no hay migraciones configuradas:
Genera una migración inicial y actualiza la base de datos con los siguientes comandos:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 3. Restaura las dependencias

En la raíz del proyecto, ejecuta el siguiente comando para restaurar las dependencias necesarias:

```bash
dotnet restore
```

---

## 4. Ejecuta el proyecto

### Usando Visual Studio:
1. Abre el archivo `.sln` del proyecto.
2. Configura el proyecto como **Startup Project**.
3. Presiona `F5` o `Ctrl+F5` para ejecutar la aplicación.

### Usando la terminal:

Ejecuta el siguiente comando:

```bash
dotnet run
```

---

## 5. Accede a la aplicación

Una vez que el servidor esté corriendo, abre tu navegador y accede a la URL correspondiente. Por defecto, será algo como:

```
https://localhost:5001
http://localhost:5000
```

---

¡Eso es todo! Si tienes algún problema o error, consulta los mensajes de la consola o abre un issue en el repositorio. 😊
