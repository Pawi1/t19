//@ts-check
import { Sphere } from '../calc/Sphere.js';

describe('Sphere', () => {
  test('stores radius', () => {
    const sphere = new Sphere(7);
    expect(sphere.r).toBe(7);
  });

  test('calculates surface area (4·π·r²)', () => {
    const sphere = new Sphere(3);
    const expected = 4 * Math.PI * Math.pow(3, 2);
    expect(sphere.surfaceArea()).toBeCloseTo(expected);
  });

  test('calculates volume (4/3·π·r³)', () => {
    const sphere = new Sphere(2);
    const expected = (4 / 3) * Math.PI * Math.pow(2, 3);
    expect(sphere.volume()).toBeCloseTo(expected);
  });
});
