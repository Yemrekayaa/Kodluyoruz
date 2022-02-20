import axios from "axios";

async function getData(userId){
    const {data: userData} = await axios(`https://jsonplaceholder.typicode.com/users/${userId}`);
    userData.posts = await (await axios(`https://jsonplaceholder.typicode.com/posts?userId=${userId}`)).data;
   return userData;
}

export default getData;