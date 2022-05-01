document
    .getElementById('url')
    .addEventListener('keyup', function (event) {
        if (event.code === 'Enter') {
            event.preventDefault();
            submitUrl();
        }
    });

function submitUrl() {
    //const xhr = new XMLHttpRequest();
    //xhr.open('POST', '/Home/Index', true);
    //xhr.setRequestHeader('Content-Type', 'application/json;charset=UTF-8');

    //xhr.onreadystatechange = function () {
    //    if (xhr.readyState === 4) {
    //        if (xhr.status === 200) {
    //            const url = JSON.parse(xhr.responseText).url;
    //            const section = document.getElementById('urlResult');
    //            section.innerHTML = `<a id="link" href="${url}">${url}</a>`;
    //        } else {
    //            alert(xhr.responseText);
    //        }
    //    }
    //};

    //xhr.send(JSON.stringify({ url: document.getElementById('url').value }));
    debugger;
    $.ajax({
        type: 'POST',
        url: '/Home/Index',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: { link: document.getElementById('url').value },
        success: function (result) {
            const section = document.getElementById('urlResult');
            section.innerHTML = `<a id="link" href="${result.data.tiny_url}" target=”_blank”>${result.data.tiny_url}</a>`;
        },
        error: function () {
            alert('Failed to receive the Data');
            console.log('Failed ');
        }
    })
}