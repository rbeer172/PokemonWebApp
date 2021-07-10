interface Node {
    name: string;
    data: Evolution | null;
}

const buildTree = (data: Array<Evolution>) => {
    const newData: Array<Array<Node>> = [
        [
            {
                name: data[0].pokemon,
                data: null,
            },
        ],
    ];
    let temp: Array<Node> = [];
    let prev = [data[0].pokemon];

    data.forEach((evolution) => {
        if (prev.includes(evolution.pokemon)) {
            temp.push({ name: evolution.evolved_pokemon, data: evolution });
        } else if (!prev.includes(evolution.pokemon)) {
            newData.push(temp);
            prev = [];
            temp.forEach((pokemon) => {
                prev.push(pokemon.name);
            });
            temp = [{ name: evolution.evolved_pokemon, data: evolution }];
        }
    });
    if (temp.length > 0) newData.push(temp);
    return newData;
};
export default buildTree;

// import { filter } from 'lodash/fp';
// interface Node {
//     name: string;
//     data: Evolution | null;
//     children: Array<Node>;
// }
// const buildTree = (data: Array<Evolution>) => {
//     const stack: Array<Node> = [];
//     const knownValues: Array<string> = [];
//     const root: Node = { name: data[0].pokemon, data: null, children: [] };

//     const filterEvolutions = (name: string) => {
//         const result = filter(
//             (evolution) => evolution.pokemon === name && !knownValues.includes(name),
//             data
//         );
//         result.forEach((element) => {
//             knownValues.push(element.pokemon);
//         });
//         return result;
//     };
//     const makeTree = (name: string) => {
//         const result = filterEvolutions(name);
//         const temp: Array<Node> = [];
//         const newNode: Node = { name, data: null, children: [] };

//         result.forEach((evolution) => {
//             makeTree(evolution.evolved_pokemon);
//             const obj = stack.pop();

//             if (obj && obj.children[0].data?.pokemon === evolution.evolved_pokemon) {
//                 obj.data = evolution;
//                 stack.push(obj);
//             } else {
//                 temp.push({ name: evolution.evolved_pokemon, data: evolution, children: [] });
//                 if (obj !== undefined) stack.push(obj);
//             }
//         });

//         if (temp.length !== 0) {
//             newNode.children = temp;
//             stack.push(newNode);
//         }
//     };
//     makeTree(data[0].pokemon);
//     stack.forEach((element) => {
//         root.children.push(element);
//     });
//     console.log('root', root);
//     return root;
// };
