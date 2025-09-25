//@ts-check
export class Sphere {
    /**
     * @param {number} r
     */
    constructor(r) {
        this.r = r;
    }
    surfaceArea(){
        return 4*Math.PI*Math.pow(this.r,2);
    }
    volume(){
        return 4/3*Math.PI*Math.pow(this.r,3);
    }
}