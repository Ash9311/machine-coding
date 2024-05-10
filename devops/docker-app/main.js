const express = require("express");

const app = express();

const PORT = process.env.PORT || 8000;

app.get('/', (req, res) => {
    return res.json({ message: "hey from docker" })
})

app.listen(PORT, () => { console.log("port running on port " + PORT) });
