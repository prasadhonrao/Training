var h = 100;
var w = 100;
var padding = 2;
var dataset = [5, 10, 15, 20, 25];
var svg = d3.select("body")
    .append("svg")
    .attr("width", w)
    .attr("height", h);

svg.selectAll("rect")
    .data(dataset)
    .enter()
    .append("rect")
    .attr({
        x: (d, i) => {
            return (i * (w / dataset.length));
        },
        y: (d) => {
            return h - (d * 4);
        },
        width: w / dataset.length - padding,
        height: (d) => {
            return (d * 4);
        },
        fill: (d) => {
            return ("rgb(" + (d * 10) + ", 0, 0)")
        }
    });
