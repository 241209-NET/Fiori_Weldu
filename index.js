function myAlert()
{
    alert("Yeah I love swimming");
}

const myBtn = document.getElementById('my-btn');
myBtn.innerText = "programing";

myBtn.addEventListener('click', function(e) {
    console.log(e);
    console.log("Button programing was pressed!");
});

const button = document.getElementById('changeColorButton');

    button.addEventListener('click', function() {
      document.body.style.backgroundColor = 'lightblue';
    });