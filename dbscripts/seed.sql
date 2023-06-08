
\connect blogdb

CREATE TABLE blog
(
    id serial PRIMARY KEY,
    title  VARCHAR (50)  NOT NULL,
    description  VARCHAR (100)  NOT NULL
);

ALTER TABLE "blog" OWNER TO bloguser;

Insert into blog(title,description) values( 'Ben Test Title 1','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 2','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 3','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 4','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 5','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 6','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 7','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 8','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 9','Ben Test Description');
Insert into blog(title,description) values( 'Ben Test Title 10','Ben Test Description');
