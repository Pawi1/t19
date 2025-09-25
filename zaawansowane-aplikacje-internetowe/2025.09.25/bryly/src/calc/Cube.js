//@ts-check
export class Cube {
    /**
     * @param {number} a
     */
    constructor(a) {
        this.a = a;
    }
    surfaceArea(){
        return 6*Math.pow(this.a,2);
    }
    volume(){
        return Math.pow(this.a,3);
    }
}