﻿abstract class Szablonowa
{
    protected abstract void attack();
}
 abstract class GameAI : Szablonowa
{
    protected sealed override void attack()
    {
        buildStructures();
        buildUnits();
        sendScouts();
        sendWarriors();
    }
     public abstract void buildStructures();
    public abstract void buildUnits();
    public abstract void sendScouts();
    public abstract void sendWarriors();
    public virtual void takeTurn() { }
    public virtual void collectResource() { }
}
 class OrcsAI : GameAI
{
    public override void buildStructures() { }
    public override void buildUnits() { }
    public override void sendScouts() { }
    public override void sendWarriors() { }
}
 class MonstersAI : GameAI
{
    public override void buildStructures() { }
    public override void buildUnits() { }
    public override void sendScouts() { }
    public override void sendWarriors() { }
    public override void collectResource() { }
}