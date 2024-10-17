Ejercicio implementando Principio de Responsabilidad Unica y Inversión de dependencias.
La Responsabilidad Unica se ve en como cada script se encarga de algo en concreto. Los controladores de recibir el Input, Los accionadores de pasar la señal a su lista de elementos, y cada elemento en particular se ocupa de hacer lo suyo al recibir la señal.
El principio de Inversión de dependencias se ve en como, independientemente de como estén formadas estas estructuras o qué elementos los componen, podemos generar el input y ver los resultados trasladados en los objetos, sin importar de su individualidad.
Asi como también algunos objetos pueden ser manejados por varios controladores al mismo tiempo, en grupo o en individual.

En el ejemplo el Controlador 1 contiene una lista con los elementos de la caja y el "foco de luz" de la izquierda, y es controlador por el jugador al presionar el botón 1.
El Controlador 2 contiene también a la caja y al "foco de luz" de la derecha, y se controla por una "IA" (se acciona cada X segundos aleatorios).

Para modificar los grupos de Controladores, simplemente arrastrar los elementos a interactuar al editor, dentro de la lista del respectivo controlador.
