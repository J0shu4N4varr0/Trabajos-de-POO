//El objeto conductorLibre vive en la memoria de la aplicación gracias a new Conductor(...), sin que ningún Colectivo lo haya gestado.

//A diferencia del ejemplo del Motor (donde el Coche creaba obligatoriamente al motor con new Motor(cil) dentro de su propio constructor), aquí el Colectivo solo tiene una propiedad opcional y modificable (public Conductor? ConductorAsignado { get; set; }) 
// que puede estar vacía (null) o recibir un conductor que ya fue creado previamente por fuera.