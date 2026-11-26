export default function Header({siteName, topicName})
{
    return(
        <div className="Header">
            <h1>Witamy na stronie: {siteName}</h1>
            <h3>Pomożemy zrozumieć i rozwiązać: {topicName}</h3>
            <hr />
        </div>
    );
}