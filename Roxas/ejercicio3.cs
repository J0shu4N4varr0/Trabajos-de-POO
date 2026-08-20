//Al hacer new Coche("Toyota", 4), el constructor de Coche ejecuta obligatoriamente new Motor(cil).
//  El motor no puede existir antes que el coche ni de manera independiente.

//Si el objeto Coche deja de ser utilizado y el recolector de basura (Garbage Collector) de C# lo elimina, 
// el objeto Motor interno se destruye automáticamente con él, ya que ninguna otra parte del código tiene 
// una referencia a ese motor.

//La propiedad public Motor Motor { get; } solo tiene el capturador (get). 
// Esto impide que el motor sea reemplazado, modificado o extraído una vez que el coche ha sido ensamblado.
// Pertenece única y exclusivamente a esa instancia de Coche.