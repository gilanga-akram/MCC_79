const pokedex = document.getElementById(`pokedex`);
const pokeCache = {};
console.log(pokedex);


const fetchPokemon = async () => {

    const url = `https://pokeapi.co/api/v2/pokemon?limit=20`;
    const res = await fetch(url);
    const data = await res.json();
    const pokemon = data.results.map((result, index) => ({
        name: result.name,
        apiURL: result.url,
        id: index + 1,
        image: `https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/${index + 1}.png`,
    }));
    displayPokemon(pokemon);
};

const displayPokemon = (pokemon) => {
    const pokemonHTMLString = pokemon
        .map(
            (pokemon) => `
                <li class="card" onclick="selectPokemon(${pokemon.id})">
                    <img class="card-image" src="${pokemon.image}"/>
                    <h2 class="card-title">${pokemon.id}. ${pokemon.name}</h2>
                </li>
            `
        )
        .join('');
    pokedex.innerHTML = `<ul class="pokedex">${pokemonHTMLString}</ul>`;
};

const selectPokemon = async (id) => {
    if (pokeCache[id]) {
        displayPopup(pokeCache[id]);
    } else {
        const url = `https://pokeapi.co/api/v2/pokemon/${id}`;
        const res = await fetch(url);
        const pokemon = await res.json();
        pokeCache[id] = pokemon;
        displayPopup(pokemon);
    }
};

const displayPopup = (pokemon) => {
    console.log(pokemon)
    const type = pokemon.types.map((type) => type.type.name).join(', ');
    const image = pokemon.sprites.front_default;
    const abilities = pokemon.abilities;
    console.log(abilities)
    const htmlString = `
        <div class="popup">
            <button id="closeBtn" onclick="closePopup()">Close</button>
            <div class="card" style="width:300px;">
                <img class="card-image" src="${image}"/>
                <h2 class="card-title">${pokemon.id}. ${pokemon.name}</h2>
                <p><small>Height: </small>${pokemon.height} | <small>Weight: </small>${pokemon.weight}</p>
                <h2>Abilities:</h2>
                <p>${pokemon.abilities.map(ability => ability.ability.name).join(" | ")}</p>
            </div>
        </div>
    `;
    pokedex.innerHTML = htmlString + pokedex.innerHTML;
    /*console.log(htmlString);*/
};

const closePopup = () => {
    const popup = document.querySelector('.popup');
    popup.parentElement.removeChild(popup);
};

fetchPokemon();