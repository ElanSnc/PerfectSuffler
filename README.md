# PerfectSuffler

He creado la clase deck abstracta y la clase PokerDeck que sera la que voy a utilizar para la prueba por motivos de extensibilidad.

Si el día de mañana la aplicacion crece y acepta otras barajas de cartas solo tendriamos que crear una clase para esa baraja en concreto.

Se podría haber usado Generics para la creacion de barajas para mayor extensibilidad pero no se especifica y me quitaria tiempo del sprint que quizas luego 
necesite para dejar el proyecto acabado y bien.

Tanto Card como Suit y Number implementan IComparable por motivos obvios, se pide un sort de la baraja y IComparable lo hace sin necesidad de escribir codigo extra.

Card deberia ser quizas una clase padre y PokerCard extender por el mismo motivo que lo hace Deck pero no voy commitear tiempo en eso por que no se especifica.

en cualquier caso, suit y number podrían aplicarse a baraja española o al uno sin tener que escribir nada, el unico problema lo tendriamos si hay que añadir 
una baraja mas rara como las cartas del Magic o algun juego raro.

He creado las cartas a partir de Suit y number por motivos de de extensibilidad por que muchas barajas consisten en dibujo y valor y para atomizar un poco.

La deck (Lista de cartas) podría haber sido un hashtable para que el shuffle fuese mas eficiento por el acceso aleatorio a memoria pero si algun día se añade 
una deck que tenga cartas iguales habria que reescribir la clase. para el tipo de aplicacion una lista funciona bien.

he sobreescrito CompareTo en Card.Number para que el sort ordene de 1 a 13, el CompareTo por defecto diria que 13 va primero por que es mayor.
