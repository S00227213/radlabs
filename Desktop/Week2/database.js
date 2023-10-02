const mongoose = require('mongoose');
require('dotenv').config();

const db = mongoose.connection;

db.on('error', console.error.bind(console, 'Connection error:'));

db.once('open', () => {
  console.log('DB connected');
});
