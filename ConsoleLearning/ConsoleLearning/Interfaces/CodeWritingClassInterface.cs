namespace ConsoleLearning.Interfaces;

abstract class Animal{}
abstract class Bird : Animal { }
abstract class Insect : Animal { }
interface FlyingCreature { }
interface Carnivore { }


class Ostrich : Bird { }
class Eagle : Bird,FlyingCreature, Carnivore  { }
class Bee : Insect,FlyingCreature  { }
class Flea : Insect,Carnivore  { }
