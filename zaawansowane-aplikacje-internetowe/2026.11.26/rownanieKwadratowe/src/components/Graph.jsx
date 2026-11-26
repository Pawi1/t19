import { Mafs, Coordinates, Plot, Point } from 'mafs';
import 'mafs/core.css';

export default function Graph({ a, b, c, delta, x }) {
    const p = -b / (2 * a);
    const q = -delta / (4 * a);
    const xs = [p - 2, p + 2, ...x];
    const ys = [0, q, q + 4 * a];

    return (
        <div className="Graph">
            <Mafs
                width={350}
                height={250}
                viewBox={{ x: [Math.min(...xs), Math.max(...xs)], y: [Math.min(...ys), Math.max(...ys)] }}
                preserveAspectRatio={false}
            >
                <Coordinates.Cartesian xAxis={{ labels: false }} yAxis={{ labels: false }} />
                <Plot.OfX y={t => a * t * t + b * t + c} color="blue" />
                {x.map((xi, i) => <Point key={i} x={xi} y={0} color="red" />)}
            </Mafs>
            <p>
                {delta > 0 && 'Parabola przecina os X w dwoch punktach'}
                {delta === 0 && 'Parabola styka sie z osia X w jednym punkcie'}
                {delta < 0 && 'Parabola nie ma punktow wspolnych z osia X'}
            </p>
        </div>
    );
}
