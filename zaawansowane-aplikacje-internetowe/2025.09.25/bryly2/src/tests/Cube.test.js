//@ts-check
import {Cube} from '../calc/Cube.js';

describe('Cube', () => {
  test('stores side length', () => {
    const cube = new Cube(5);
    expect(cube.a).toBe(5);
  });

  test('calculates surface area (6·a²)', () => {
    const cube = new Cube(2);
    expect(cube.surfaceArea()).toBe(6 * Math.pow(2, 2));
  });

  test('calculates volume (a³)', () => {
    const cube = new Cube(3);
    expect(cube.volume()).toBe(Math.pow(3, 3));
  });
});
