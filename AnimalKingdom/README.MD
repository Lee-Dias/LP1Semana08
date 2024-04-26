``` mermaid

      classDiagram
      class Animal {          
      }

      class Dog {    
      }

      class Cat {
      }

      class Bat {
      }

      class Bee {
      }

      class IMammal {
            
      }

      class ICanFly {
            
      }

      class Program {
      }


    Animal --> Program
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Bat
    Animal <|-- Bee
    IMammal <|-- Dog
    IMammal <|-- Cat
    IMammal <|-- Bat
    ICanFly <|-- Bat
    ICanFly <|-- Bee





```