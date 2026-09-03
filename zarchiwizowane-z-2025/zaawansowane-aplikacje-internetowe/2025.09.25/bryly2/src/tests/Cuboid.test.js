//@ts-check
import { Cuboid } from '../calc/Cuboid.js';

describe('Cuboid', () => {
  test('stores dimensions', () => {
    const cuboid = new Cuboid(2, 3, 4);
    expect(cuboid.a).toBe(2);
    expect(cuboid.b).toBe(3);
    expect(cuboid.h).toBe(4);
  });

  test('calculates surface area (2·(ab + ah + bh))', () => {
    const cuboid = new Cuboid(2, 3, 4);
    const expected = 2 * (2 * 3 + 2 * 4 + 3 * 4);
    expect(cuboid.surfaceArea()).toBe(expected);
  });

  test('calculates volume (a·b·h)', () => {
    const cuboid = new Cuboid(2, 3, 4);
    const expected = 2 * 3 * 4;
    expect(cuboid.volume()).toBe(expected);
  });
});