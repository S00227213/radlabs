const mongoose = require('mongoose');
require('dotenv').config();

const connectionString = process.env.CONNECTIONSTRING;

mongoose
  .connect(connectionString, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  })
  .catch((error) => {
    console.error(`Database connection refused ${error}`);
    process.exit(2);
  });

const db = mongoose.connection;

db.on('error', console.error.bind(console, 'Connection error:'));

db.once('open', () => {
  console.log('DB connected ' + connectionString);
});
