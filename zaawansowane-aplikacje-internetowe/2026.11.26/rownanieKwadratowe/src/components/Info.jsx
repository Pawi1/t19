export default function Info()
{
    return(
        <div className="Info">
            <h4><u>Postać ogolna:</u></h4>
            <p>ax²+bx+c=0</p>
            <p>wyróżnik równania kwadratowego</p>
                <div className="definition">
                    delta = b²-4ac
                    <ul>
                        <li>jeśli delta &gt; 0 to równanie ma dwa rozwiązania:<br />x₁=(-b-√delta)/2a <br />x₂=(-b+√delta)/2a</li>
                        <li>jeśli delta = 0 to równanie ma jedno rozwiązanie: <br />x₀=(-b)/(2a)</li>
                        <li>jeśli delta &lt; 0 to równanie nie ma rozwiązania</li>
                    </ul>
                </div>
            <hr />
        </div>
    );
}