# Singleton
Example Singleton Sealed and Singleton Hierarchy

El funcionamiento de este patrón es muy sencillo y podría reducirse a los siguientes conceptos:
 - Ocultar el constructor de la clase Singleton, para que los clientes no puedan crear instancias.
 - Declarar en la clase Singleton una variable miembro privada que contenga la referencia a la instancia única que queremos gestionar.
 - Proveer en la clase Singleton una función o propiedad que brinde acceso a la única instancia gestionada por el Singleton. 
   Los clientes acceden a la instancia a través de esta función o propiedad.


MSDN
https://msdn.microsoft.com/es-es/library/bb972272.aspx#m251
