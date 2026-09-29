class Cube {
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
class Cuboid {
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
class Sphere {
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
export class Calc {
    calc(type, operation, ...dimensions) {
        let shape;
        switch (type) {
            case "cube":
                shape = new Cube(dimensions[0]);
                break;
            case "cuboid":
                shape = new Cuboid(dimensions[0], dimensions[1], dimensions[2]);
                break;
            case "sphere":
                shape = new Sphere(dimensions[0]);
                break;
            default:
                return null;
        }
        switch (operation) {
            case "surfaceArea":
                return shape.surfaceArea()
            case "volume":
                return shape.volume()
            default:
                return null;
        }
    }
}