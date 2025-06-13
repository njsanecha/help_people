# Help People API

_Help People es una tienda de compras en línea diseñada para ser accesible y funcional para todos. Su objetivo principal es ofrecer una experiencia de usuario sencilla, eficiente e inclusiva, permitiendo a los usuarios explorar una amplia variedad de productos, conocer sus detalles, y adquirir lo que necesiten de manera fácil y rápida._


## Características Principales

**🔹 Exploración de productos:**
Los usuarios pueden navegar por un catálogo diverso de productos, organizado por categorías, con información detallada de cada artículo (nombre, descripción, precio, imagen, etc.).

**🔹 Carrito de compras y checkout:**
La plataforma permite agregar productos al carrito y gestionar sus cantidades, además de realizar el proceso de compra completo a través de un sistema de checkout intuitivo.

**🔹 Gestión de categorías y productos:**
Incluye funcionalidades CRUD (Crear, Leer, Editar, Eliminar) tanto para productos como para categorías, facilitando la administración del contenido de la tienda por parte del equipo responsable.


## Objetivo del Proyecto ✅
Brindar una solución de comercio electrónico que sea útil, accesible y flexible, promoviendo una experiencia de compra satisfactoria para los usuarios y una gestión eficiente para los administradores.


## Comenzando 🚀

Para ejecutar el backend de la tienda **Help People** en un entorno local, es necesario cumplir con los siguientes requisitos y configuraciones:


### Pre-requisitos 📋

El backend del proyecto ha sido desarrollado utilizando en **.NET** y **SQL Server**, proporcionando una interfaz rápida, moderna y totalmente responsiva.

🔹 [.NET SDK](https://dotnet.microsoft.com/download) (versión compatible con el proyecto)

🔹 [Visual Studio Code](https://code.visualstudio.com/)

🔹 [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (instancia local o en la nube)

🔹 Herramientas de migración de Entity Framework Core (opcional pero recomendado)


### Instalación 🔧

**1. Clona el repositorio del proyecto:**

   ```bash
   git clone https://github.com/njsanecha/help_people.git
   cd help_people
   ```

**2. Abre el proyecto en Visual Studio Code:**

   ```bash
   code .
   ```

**3. Configura la cadena de conexión:**

   Abre el archivo `appsettings.Development.json` y modifica la sección `ConnectionStrings` con los datos de tu servidor SQL:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=HelpPeopleDB;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

**4. Crear la base de datos (si es necesario):**

   🔹 Asegúrate de que la base de datos `HelpPeople` exista o usa migraciones para crearla automáticamente (si se está usando Entity Framework). 
   
   🔹 Los SCRIPTS para la creación de las tablas de la base de datos estan disponibles en el repositorio.

**5. Ejecuta la API:**

   ```bash
   dotnet run
   ```

**6. Acceder a la API:**

   🔹 Una vez ejecutada, la API estará disponible en `https://localhost:7125` o `http://localhost:5276`, según la configuración del proyecto.



## Autor ✒️

**Nhora Sandoval** [Help People](https://github.com/njsanecha/help_people)

