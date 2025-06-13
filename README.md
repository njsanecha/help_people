# Help People API

_Help People es una tienda de compras en línea diseñada para ser accesible y funcional para todos. Su objetivo principal es ofrecer una experiencia de usuario sencilla, eficiente e inclusiva, permitiendo a los usuarios explorar una amplia variedad de productos, conocer sus detalles, y adquirir lo que necesiten de manera fácil y rápida._


## Características Principales:

Exploración de productos:
Los usuarios pueden navegar por un catálogo diverso de productos, organizado por categorías, con información detallada de cada artículo (nombre, descripción, precio, imagen, etc.).

Carrito de compras y checkout:
La plataforma permite agregar productos al carrito y gestionar sus cantidades, además de realizar el proceso de compra completo a través de un sistema de checkout intuitivo.

Gestión de categorías y productos:
Incluye funcionalidades CRUD (Crear, Leer, Editar, Eliminar) tanto para productos como para categorías, facilitando la administración del contenido de la tienda por parte del equipo responsable.


## Objetivo del Proyecto:
Brindar una solución de comercio electrónico que sea útil, accesible y flexible, promoviendo una experiencia de compra satisfactoria para los usuarios y una gestión eficiente para los administradores.


## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

Mira **Deployment** para conocer como desplegar el proyecto.


### Pre-requisitos 📋

Para ejecutar el backend de la tienda **Help People** en un entorno local, es necesario cumplir con los siguientes requisitos y configuraciones:

#### **Requisitos Previos:**

* **Visual Studio Code**
  Editor de código recomendado para trabajar con el proyecto y ejecutar la API.

* **.NET SDK (versión compatible con el proyecto)**
  Necesario para compilar y ejecutar la API.

* **SQL Server (local)**
  Motor de base de datos utilizado para almacenar la información de productos, categorías y pedidos.

_Que cosas necesitas para instalar el software y como instalarlas_

```
Da un ejemplo
```

### Instalación 🔧

_Una serie de ejemplos paso a paso que te dice lo que debes ejecutar para tener un entorno de desarrollo ejecutandose_

_Dí cómo será ese paso_

```
Da un ejemplo
```

_Y repite_

```
hasta finalizar
```

_Finaliza con un ejemplo de cómo obtener datos del sistema o como usarlos para una pequeña demo_

Perfecto. A continuación, te dejo una sección que puedes agregar a la descripción del proyecto o documentarla como parte del archivo `README.md`, explicando claramente los **requisitos previos** y cómo correr la API localmente:

---

### **Requisitos para Ejecutar la API de Help People**


---

### **Pasos para Ejecutar la API Localmente:**

1. **Clonar el repositorio del proyecto.**

2. **Abrir el proyecto en Visual Studio Code.**

3. **Configurar la cadena de conexión:**

   * Dirígete al archivo `appsettings.Development.json`.
   * Modifica la propiedad `ConnectionStrings.DefaultConnection` con los datos correspondientes a tu instancia local de SQL Server.
     Ejemplo:

     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=localhost;Database=HelpPeopleDB;Trusted_Connection=True;TrustServerCertificate=True;"
       }
     }
     ```

4. **Crear la base de datos (si es necesario):**

   * Asegúrate de que la base de datos `HelpPeopleDB` exista o usa migraciones para crearla automáticamente (si se está usando Entity Framework).

5. **Ejecutar el proyecto:**

   * Desde la terminal integrada de VS Code, corre el siguiente comando:

     ```
     dotnet run
     ```

6. **Acceder a la API:**

   * Una vez ejecutada, la API estará disponible en `https://localhost:5001` o `http://localhost:5000`, según la configuración del proyecto.

---

¿Te gustaría que también escriba una versión del README completa con esto incluido?


## Ejecutando las pruebas ⚙️

_Explica como ejecutar las pruebas automatizadas para este sistema_

### Analice las pruebas end-to-end 🔩

_Explica que verifican estas pruebas y por qué_

```
Da un ejemplo
```

### Y las pruebas de estilo de codificación ⌨️

_Explica que verifican estas pruebas y por qué_

```
Da un ejemplo
```

## Despliegue 📦

_Agrega notas adicionales sobre como hacer deploy_

## Construido con 🛠️

_Menciona las herramientas que utilizaste para crear tu proyecto_

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - El framework web usado
* [Maven](https://maven.apache.org/) - Manejador de dependencias
* [ROME](https://rometools.github.io/rome/) - Usado para generar RSS

## Contribuyendo 🖇️

Por favor lee el [CONTRIBUTING.md](https://gist.github.com/villanuevand/xxxxxx) para detalles de nuestro código de conducta, y el proceso para enviarnos pull requests.

## Wiki 📖

Puedes encontrar mucho más de cómo utilizar este proyecto en nuestra [Wiki](https://github.com/tu/proyecto/wiki)

## Versionado 📌

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/tu/proyecto/tags).

## Autores ✒️

_Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios_

* **Andrés Villanueva** - *Trabajo Inicial* - [villanuevand](https://github.com/villanuevand)
* **Fulanito Detal** - *Documentación* - [fulanitodetal](#fulanito-de-tal)

También puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) quíenes han participado en este proyecto. 

## Licencia 📄

Este proyecto está bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles

## Expresiones de Gratitud 🎁

* Comenta a otros sobre este proyecto 📢
* Invita una cerveza 🍺 o un café ☕ a alguien del equipo. 
* Da las gracias públicamente 🤓.
* Dona con cripto a esta dirección: `0xf253fc233333078436d111175e5a76a649890000`
* etc.



---
⌨️ con ❤️ por [Villanuevand](https://github.com/Villanuevand) 😊

visual studio instalado (link de instalacion)
SQL server instalado (link de instalacion)
modificar la cadena de conexión en el archivo add. settings

