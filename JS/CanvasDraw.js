function drawLines()
{
    var canvas = document.getElementsByClassName("lines");
    for (var i = 0; i < canvas.length; i++)
    {
        var width = canvas[i].width;
        var height = canvas[i].height;
        var ctx = canvas[i].getContext("2d");

        ctx.fillStyle = 'white';

        //Left line
        ctx.beginPath()
        ctx.moveTo(width * .5, 0);
        //Top right to bottom right
        ctx.lineTo(width * .2, height);
        //Bottom right to bottom left
        ctx.lineTo(width * 0, height);
        //Bottom left to top left
        ctx.lineTo(width * .3, 0);
        //Top left to top right
        ctx.lineTo(width * .5, 0);
        ctx.closePath();

        ctx.fill();

        //Right line
        ctx.beginPath()
        ctx.moveTo(width * .8, 0);
        //Top right to bottom right
        ctx.lineTo(width * .5, height);
        //Bottom right to bottom left
        ctx.lineTo(width * .3, height);
        //Bottom left to top left
        ctx.lineTo(width * .6, 0);
        //Top left to top right
        ctx.lineTo(width * .8, 0);
        ctx.closePath();

        ctx.fill();
    }
}

function flipColour(canvasNum)
{
    var canvas = document.getElementsByClassName("lines");
    var width = canvas[canvasNum].width;
    var height = canvas[canvasNum].height;
    var ctx = canvas[canvasNum].getContext("2d");

    ctx.fillStyle = 'black';

    //Left line
    ctx.beginPath()
    ctx.moveTo(width * .5, 0);
    //Top right to bottom right
    ctx.lineTo(width * .2, height);
    //Bottom right to bottom left
    ctx.lineTo(width * 0, height);
    //Bottom left to top left
    ctx.lineTo(width * .3, 0);
    //Top left to top right
    ctx.lineTo(width * .5, 0);
    ctx.closePath();

    ctx.fill();

    //Right line
    ctx.beginPath()
    ctx.moveTo(width * .8, 0);
    //Top right to bottom right
    ctx.lineTo(width * .5, height);
    //Bottom right to bottom left
    ctx.lineTo(width * .3, height);
    //Bottom left to top left
    ctx.lineTo(width * .6, 0);
    //Top left to top right
    ctx.lineTo(width * .8, 0);
    ctx.closePath();

    ctx.fill();
}

function reflipColour(canvasNum)
{
    var canvas = document.getElementsByClassName("lines");
    var width = canvas[canvasNum].width;
    var height = canvas[canvasNum].height;
    var ctx = canvas[canvasNum].getContext("2d");

    ctx.fillStyle = 'white';

    //Left line
    ctx.beginPath()
    ctx.moveTo(width * .5, 0);
    //Top right to bottom right
    ctx.lineTo(width * .2, height);
    //Bottom right to bottom left
    ctx.lineTo(width * 0, height);
    //Bottom left to top left
    ctx.lineTo(width * .3, 0);
    //Top left to top right
    ctx.lineTo(width * .5, 0);
    ctx.closePath();

    ctx.fill();

    //Right line
    ctx.beginPath()
    ctx.moveTo(width * .8, 0);
    //Top right to bottom right
    ctx.lineTo(width * .5, height);
    //Bottom right to bottom left
    ctx.lineTo(width * .3, height);
    //Bottom left to top left
    ctx.lineTo(width * .6, 0);
    //Top left to top right
    ctx.lineTo(width * .8, 0);
    ctx.closePath();

    ctx.fill();
}
