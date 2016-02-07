FROM node:slim

WORKDIR /node-app
ADD package.json /node-app/
RUN npm install
ADD . /node-app

CMD ["node", "app.js"]
