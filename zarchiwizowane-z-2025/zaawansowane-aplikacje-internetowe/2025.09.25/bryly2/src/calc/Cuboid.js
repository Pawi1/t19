//@ts-check
export class Cuboid {
    /**
     * @param {number} a
     * @param {number} b
     * @param {number} h
     */
    constructor(a,b,h) {
        this.a = a;
        this.b = b;
        this.h = h;
    }
    surfaceArea(){
        return 2*this.a*this.b+2*this.a*this.h+2*this.h*this.b;
    }
    volume(){
        return this.a*this.b*this.h;
    }
}