# Embed Sender

**Embed Sender** es una herramienta de Windows Forms diseñada para enviar notificaciones personalizadas a un canal específico en Discord mediante webhooks. Esta aplicación facilita la creación de mensajes embebidos (embeds) con varios campos personalizables, incluyendo título, descripción, color, imágenes, autor, y más.


## Características

- **Webhook URL**: Configura la URL del webhook de Discord al que se enviará el mensaje.
- **Título y Descripción del Embed**: Define el título y la descripción del mensaje embebido, con soporte para múltiples párrafos.
- **Color**: Establece el color del embed usando un código hexadecimal.
- **Imágenes**: Añade una imagen principal y una miniatura al embed.
- **Autor**: Incluye nombre, URL y un icono para el autor del mensaje.
- **Campos Adicionales**: Agrega múltiples campos con nombre y valor para información adicional.
- **Guardar y Cargar Configuraciones**: Guarda configuraciones personalizadas y cárgalas cuando sea necesario.

## Uso

1. **Configura el Webhook URL**: Introduce la URL del webhook de Discord. Puedes obtener la URL del webhook creando uno en tu servidor de Discord:
   - Ve a tu servidor de Discord.
   - Dirígete a "Configuración del servidor" > "Integraciones" > "Webhooks".
   - Crea un nuevo webhook y copia la URL.

2. **Personaliza el Mensaje Embed**:
   - **Título y Descripción**: Ingresa el título y la descripción de tu mensaje.
   - **Color**: Introduce el color del embed en formato hexadecimal (sin el `#`).
   - **Imágenes**: Proporciona las URLs para la imagen principal y la miniatura.
   - **Autor**: Añade el nombre, URL e icono del autor.
   - **Campos**: Agrega campos adicionales según sea necesario.

3. **Enviar, Guardar y Cargar**:
   - **Enviar**: Haz clic en el botón "Enviar" para enviar el embed a Discord.
   - **Guardar**: Guarda tu configuración para uso futuro.
   - **Cargar**: Carga configuraciones previamente guardadas.

## Contribuciones

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el programa o encuentras algún error, por favor sigue estos pasos:

1. Haz un fork de este repositorio.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza tus cambios y haz commit (`git commit -m 'Agregar nueva funcionalidad'`).
4. Sube tus cambios (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request en GitHub.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.

## Créditos

Creado por [Nicolhetti](https://github.com/Nicolhetti).

Tester [aleferreiro703](https://github.com/aleferreiro703)

---

Para más detalles sobre cómo configurar webhooks en Discord, consulta la [documentación oficial de Discord](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks).
