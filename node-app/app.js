var express = require('express');
var app = express();

app.get('/node', function (req, res) {
  res.send('Hello World from Node.js app! container id = ' + process.env.HOSTNAME);
});

var server = app.listen(3000, function () {
  console.log('Server listening at port 3000');
});