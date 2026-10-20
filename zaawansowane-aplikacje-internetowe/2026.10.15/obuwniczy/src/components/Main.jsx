import Shoe from './Shoe' 

export default function Main({ shoes }) {
  return (
    <div className="Main">
        <div className="filters">
            <button onClick={() => window.shoesFilter('letnie')}>Przyjmij obuwie letnie</button>
            <button onClick={() => window.shoesFilter('zimowe')}>Przyjmij obuwie zimowe</button>
            <button onClick={() => window.shoesFilter('removeSoldOut')}>Usuń wyprzedane</button>
        </div>
        <div className="list" >
            {shoes.map((shoe)=>(
                <Shoe key={shoe.name} shoe={shoe}/>
            ))}
        </div>
    </div>
  );
}
