//@ts-check
import { Cube } from './Cube.js';
import { Cuboid } from './Cuboid.js';
import { Sphere } from './Sphere.js';
export class Calc {
    /**
      * @param {string} type
      * @param {string} operation
      * @param {number[]} dimensions
     **/
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