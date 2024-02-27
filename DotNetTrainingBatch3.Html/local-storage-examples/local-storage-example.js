const tblBlog = 'Tbl_Blog';

runBlog();

function runBlog() {
    readBlog();
    // createBlog('title', 'author', 'content');

    // editBlog('0f9c7ca0-42d7-4613-a851-80760503f047');
    // editBlog('0');

    // const id = prompt("Enter ID");
    // deleteBlog(id);

    //  const id = prompt("Enter ID");
    //  const title  = prompt("Enter Title");
    //  const author  = prompt("Enter Author");
    //  const content  = prompt("Enter Content");

    //  updateBlog(id, title, author, content);
}

function readBlog() {
    let lstBlog = getBlogs();

    for (let i = 0; i < lstBlog.length; i++) {
        const item = lstBlog[i];
        console.log(item.Title);
        console.log(item.Author);
        console.log(item.Content);
    }
}

function editBlog(id) {
    let lstBlog = getBlogs();

    let lst = lstBlog.filter(x => x.Id === id); // array
    if (lst.length === 0) {
        console.log('No data found.');
        return;
    }

    let item = lst[0];
    console.log(item);
}

function createBlog(title, author, content) {
    let lstBlog = getBlogs();

    const blog = {
        Id: uuidv4(),
        Title: title,
        Author: author,
        Content: content
    }

    lstBlog.push(blog);

    setLocalStorage(lstBlog);
}

function updateBlog(id, title, author, content) {
    let lstBlog = getBlogs();

    let lst = lstBlog.filter(x => x.Id === id); // array
    if (lst.length === 0) {
        console.log('No data found.');
        return;
    }

    let index = lstBlog.findIndex(x=> x.Id === id);
    lstBlog[index] = {
        Id: id,
        Title: title,
        Author: author,
        Content: content
    }

    setLocalStorage(lstBlog);
}

function deleteBlog(id) {
    let lstBlog = getBlogs();

    let lst = lstBlog.filter(x => x.Id === id); // array
    if (lst.length === 0) {
        console.log('No data found.');
        return;
    }

    lstBlog = lstBlog.filter(x=> x.Id !== id);

    setLocalStorage(lstBlog);
}

function uuidv4() {
    return "10000000-1000-4000-8000-100000000000".replace(/[018]/g, c =>
        (c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> c / 4).toString(16)
    );
}

function getBlogs() {
    let lstBlogs = [];
    let blogStr = localStorage.getItem(tblBlog);
    if (blogStr != null) {
        lstBlogs = JSON.parse(blogStr);
    }

    return lstBlogs;
}

function setLocalStorage(blogs){
    let jsonStr = JSON.stringify(blogs);
    localStorage.setItem(tblBlog, jsonStr);
}