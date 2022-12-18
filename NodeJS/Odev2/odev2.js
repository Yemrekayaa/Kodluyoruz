const posts = [{title: "1", text: "1"},{title: "2", text: "2"}];

const listPosts = () => {
    console.log("Gönderi Listesi")
    posts.map(post => {
        console.log(post);
    });
}


const addPost = (newPost) => {
    const postPromise = new Promise((resolve, reject) => {
        if(posts.push(newPost)) {
            listPosts();
            resolve();
        }else{
            reject("Gönderi eklenemedi.");
        }
        
    });
    return postPromise
}

async function showPosts(){
    try {
        listPosts()
        await addPost({title: "3", text: "3"});
    } catch (error) {
        console.log(error)
    }
}

showPosts()