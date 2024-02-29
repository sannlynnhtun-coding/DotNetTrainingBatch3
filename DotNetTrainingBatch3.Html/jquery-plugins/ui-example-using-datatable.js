const tblBlog = 'Tbl_Blog';
let _blogId = '';

runBlog();

function generateData(rowCount) {
    for (let i = 0; i < rowCount; i++) {
        let no = i + 1;
        createBlog('title' + no, 'author' + no, `content ${no}`);
    }
}

function runBlog() {
    readBlog();
    // createBlog('title', 'author', 'content');

    // editBlog('0f9c7ca0-42d7-4613-a851-80760503f047');
    // editBlog('0');


    // const id = prompt("Enter ID");
    // const title = prompt("Enter Title");
    // const author = prompt("Enter Author");
    // const content = prompt("Enter Content");

    // updateBlog(id, title, author, content);
    // deleteBlog(id);
}

function readBlog() {
    if ($.fn.DataTable.isDataTable('#datatable')) {
        console.log('destory datatable');
        $('#datatable').DataTable().destroy();
    }

    $('#tbDataTable').html('');

    let lstBlog = getBlogs();

    let htmlRow = '';

    for (let i = 0; i < lstBlog.length; i++) {
        const item = lstBlog[i];
        // console.log(item.Title);
        // console.log(item.Author);
        // console.log(item.Content);

        htmlRow += `
                    <tr>
                        <td>
                            <button type="button" class="btn btn-warning" onclick="editBlog('${item.Id}')">Edit</button>
                            <button type="button" class="btn btn-danger" onclick="deleteBlog('${item.Id}')">Delete</button>
                        </td>
                        <th scope="row">${i + 1}</th>
                        <td>${item.Title}</td>
                        <td>${item.Author}</td>
                        <td>${item.Content}</td>
                    </tr>
                    `
    }
    // console.log(htmlRow);
    $('#tbDataTable').html(htmlRow);
    new DataTable('#datatable');
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

    $('#Title').val(item.Title);
    $('#Author').val(item.Author);
    $('#Content').val(item.Content);

    _blogId = item.Id;
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

    readBlog();
}

function updateBlog(id, title, author, content) {
    let lstBlog = getBlogs();

    let lst = lstBlog.filter(x => x.Id === id); // array
    if (lst.length === 0) {
        console.log('No data found.');
        return;
    }

    let index = lstBlog.findIndex(x => x.Id === id);
    lstBlog[index] = {
        Id: id,
        Title: title,
        Author: author,
        Content: content
    }

    setLocalStorage(lstBlog);
    
    readBlog();
}

function deleteBlog(id) {
    Notiflix.Confirm.show(
        'Confirm',
        "Are you sure want to delete?",
        'Yes',
        'No',
        function okCb() {
            Notiflix.Block.dots('#frm1');

            setTimeout(() => {
                let lstBlog = getBlogs();

                let lst = lstBlog.filter(x => x.Id === id); // array
                if (lst.length === 0) {
                    console.log('No data found.');
                    return;
                }

                lstBlog = lstBlog.filter(x => x.Id !== id);

                setLocalStorage(lstBlog);

                Notiflix.Block.remove('#frm1');

                successMessage('Deleting Successful.');

                readBlog();
            }, 3000);
        },
        function cancelCb() {
        }
    );
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

function setLocalStorage(blogs) {
    let jsonStr = JSON.stringify(blogs);
    localStorage.setItem(tblBlog, jsonStr);
}

$('#btnSave').click(function () {
    const title = $('#Title').val();
    const author = $('#Author').val();
    const content = $('#Content').val();

    if (_blogId === '') {
        Notiflix.Loading.circle();
        setTimeout(() => {
            createBlog(title, author, content);
            Notiflix.Loading.remove();
            successMessage('Saving Successful.');
        }, 3000);
    }
    else {
        Notiflix.Loading.circle();
        setTimeout(() => {
            updateBlog(_blogId, title, author, content);
            Notiflix.Loading.remove();
            successMessage('Updating Successful.');
            _blogId = '';
        }, 3000);
    }

    $('#Title').val('');
    $('#Author').val('');
    $('#Content').val('');

    $('#Title').focus();

    readBlog();
})

function successMessage(message) {
    // Notiflix.Notify.success(message);
    Notiflix.Report.success(
        'Success',
        message,
        'Okay',
    );
}