<h1>Restaurante APP</h1> 

![badged-os](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![badged-os](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white) ![badged-os](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<h3 align="center">V 1.0.0</h3>


***

![badged-os](/public/images/menuApp.png)

Restaurante app es una aplicacion que simula el funcionamiento de un restaurante , permitiendo la toma de pedidos por parte de los clientes ,
permitiendo elegir la forma de entrega el pedido y los platillos que contienen los mismos. Este proyecto es hecho unicamente con fines educativos para aprender el funcionamiento de EntityFramework Core y unificar conocimientos de bases de datos , metodologias de la programacion , algoritmos , etc.

***
## Contents
1. [Features](#Features) 🆕
2. [Installation](#Installation) 💽

***
## Features

-   3 ejemplos de formas de entrega ya cargados!
-   20 ejemplos de platillos ya cargados!
-   10 ejemplos de Tipo de mercaderia ya cargados!
-   Se agrego la funcionalidad para generar pedidos
-   Se agrego la funcionalidad para listar todos los pedidos
-   Se agrego la funcionalidad para ver el menu completo
-   Se agrego la funcionalidad para consultar un pedido


***
## Installation

![vs](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)

#### Previo a todo debemos de tener SQL server y Visual Studio  instalado en nuestra maquina
#### Para poner en marcha el proyecto siga el procedimiento al pie de la letra:



-Paso 1:  Descargue el proyecto desde GitHub con el siguiente comando y abra el proyecto utilizando Visual Code, recuerde que previamente debe de tener autorizacion

    ```
    git clone https://github.com/Gabyx708/ProyectSoft_Tpindividual.git
    ```

-Paso 2 : Abra la consola de administrador de paquetes NuGet y seleccione "Infrastructure" a continuacion introduzca los siguientes comandos:

    ```
    add-migration init
    update-database
    ```
El output de la consola deberia de verse asi:

![output-PM](/public/images/NuGetConsole.png)

-Paso 3: A continuacion ejecute el proyecto RestauranteApp desde la barra superior en Visual Studio como se muestra en la imagen

![execute-screen](/public/images/Execute.png)

Si todo sale bien la aplicacion deberia comenzar a funcionar y se manifestara como una consola en la pantalla!!

![desktop](/public/images/General.png)


***

