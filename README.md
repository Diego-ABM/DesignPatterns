# DesignPatterns

# Patrones de Diseño en C#

Los patrones de diseño son soluciones reutilizables y probadas para problemas comunes en el desarrollo de software. Sirven como guías para estructurar el código de manera eficiente, mantenible y escalable. Los patrones de diseño no son específicos de un lenguaje de programación, pero se pueden implementar en C# y otros lenguajes orientados a objetos.

## Categorías de Patrones de Diseño

### Patrones Creacionales
Se centran en la creación de objetos, ayudando a controlar cómo se crean las instancias.

### Patrones Estructurales
Se enfocan en la composición de clases y objetos, ayudando a garantizar que las relaciones entre ellos sean eficientes y fáciles de mantener.

### Patrones de Comportamiento
Se encargan de la interacción y responsabilidad entre objetos, optimizando cómo se comunican y colaboran.

## Organización de Patrones de Diseño de Menos Complejos a Más Complejos

### 1. Patrones Creacionales (fáciles a intermedios)

- **Singleton:** Garantiza que una clase tenga solo una instancia y proporciona un punto de acceso global a ella.
- **Factory Method:** Define una interfaz para crear objetos, pero permite que las subclases alteren el tipo de objetos que se crearán.
- **Abstract Factory:** Proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.
- **Builder:** Separa la construcción de un objeto complejo de su representación, permitiendo la creación paso a paso.
- **Prototype:** Permite crear nuevos objetos copiando instancias existentes.

### 2. Patrones Estructurales (intermedios)

- **Adapter:** Permite que clases con interfaces incompatibles trabajen juntas, convirtiendo la interfaz de una clase en otra que un cliente espera.
- **Decorator:** Agrega funcionalidad adicional a un objeto de manera dinámica sin alterar su estructura.
- **Facade:** Proporciona una interfaz simplificada a un conjunto complejo de interfaces en un subsistema.
- **Proxy:** Proporciona un sustituto o marcador de posición para controlar el acceso a otro objeto.
- **Composite:** Permite a los clientes tratar objetos individuales y composiciones de objetos de manera uniforme.

### 3. Patrones de Comportamiento (intermedios a avanzados)

- **Observer:** Define una dependencia de uno a muchos entre objetos para que cuando un objeto cambie de estado, todos sus dependientes sean notificados y actualizados automáticamente.
- **Strategy:** Permite a una familia de algoritmos, encapsulándolos y haciéndolos intercambiables.
- **Command:** Encapsula una solicitud como un objeto, lo que permite parametrizar clientes con diferentes solicitudes, encolar o registrar solicitudes, y soportar operaciones que se pueden deshacer.
- **Template Method:** Define el esqueleto de un algoritmo en una operación, delegando algunos pasos a subclases.
- **Chain of Responsibility:** Evita acoplar al remitente de una solicitud con su receptor, dándole a más de un objeto la oportunidad de manejar la solicitud.

## Plan de Estudio Sugerido

### Comienza con Patrones Creacionales:

1. Aprende primero el patrón **Singleton**, seguido de **Factory Method** y **Abstract Factory**.
2. Después, estudia **Builder** y **Prototype**.

### Continúa con Patrones Estructurales:

1. Inicia con **Adapter** y **Facade** por ser más fáciles de entender.
2. Luego avanza a **Decorator** y **Composite**.
3. Finalmente, estudia **Proxy**.

### Finaliza con Patrones de Comportamiento:

1. Comienza con **Strategy** y **Observer**, ya que son más comunes y fáciles de aplicar.
2. Luego, aprende **Template Method** y **Command**.
3. Finaliza con **Chain of Responsibility**.

Este orden te permitirá progresar de los conceptos más sencillos a los más avanzados, construyendo una base sólida en patrones de diseño en C#.
