
# Tabla de tiempos

| Solución | Estado | Tiempo de Ejecución (hh:mm:ss) | Tiempo Aprox. (ms) |
| :--- | :--- | :--- | :--- |
| **Sincrono** | Completado | `00:00:04.3594915` | ~4359 ms |
| **AsincronMalo** | Completado | `00:00:01.5797463` | ~1580 ms |
| **AsincronoMaloToken** | Cancelado (Timeout) | `00:00:00.5130772` | ~513 ms |
| **AsincronoProBueno** | Completado | `00:00:00.5385270` | ~539 ms |
| **AsincronoProBuenoToken** | Cancelado (Timeout) | `00:00:00.5146555` | ~515 ms |
| **AsincronoProMalo** | Completado | `00:00:00.5234847` | ~523 ms |
| **AsincronoProMaloToken** | Completado | `00:00:00.3099345` | ~310 ms |

---

Aunque el ejercicio constaba de 5 soluciones, he decidido añadir una más que creo que es la más apropiada, pero que al no cumplir la regla del `CancellationToken` tuve que descartar por otra solución que sí la cumpliese.

### ¿Qué diferencias has observado entre las soluciones?
- La síncrona y la asíncrona mala (un asíncrono mal hecho que en la práctica termina funcionando como código síncrono) tienen tiempos similares de ejecución.
- Los asíncronos más eficientes tardan menos de la mitad que el síncrono y el asíncrono malo.

### ¿Qué acciones se pueden ejecutar a la vez y cuáles no? ¿Por qué?
De manera lógica no se podría ejecutar a la vez tostar el pan y untar la mermelada, o calentar la sartén al mismo tiempo que cocinar los huevos o el bacon. El resto depende de si se tiene cafetera y varios fuegos, porque pudiendo dejar uno procesándose puedes aprovechar para hacer otra tarea como servir zumo o untar la mermelada en el pan.

### ¿Qué ha pasado con cada solución cuando introduces el timeout?
Se lanza una excepción que necesita ser capturada para que la aplicación no colapse, lo cual me ha obligado a crear una nueva solución para poder sobrepasar el límite.

### ¿El enfoque con mejor rendimiento es también el más seguro? ¿Por qué?
El que mejor rendimiento ha ofrecido es en el que paralelizo todas las acciones ignorando la lógica de ejecución anteriormente planeada. Además, este método es más ineficiente en términos de sistema ya que consume más recursos y es bloqueante, pero al ser acciones pequeñas en este caso no se nota mucho.

### ¿Merece la pena complicarse con paralelismo o con mecanismos de control de tiempo? Justifica tu respuesta.
Creo que tratar de crear un código bien optimizado sería lo esperable para poder decir que se ha hecho un buen trabajo y poder cumplir las expectativas en aplicaciones o tareas exigentes que requieran procesar muchos datos o llamadas. Sin embargo, no creo estar muy de acuerdo con optimizar al máximo cuando la aplicación no lo requiere: puede ser tiempo perdido que se podría haber dedicado a otra función, aunque hay excepciones como apps de streaming o juegos competitivos en los que cada milisegundo importa.