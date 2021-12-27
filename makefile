build-image:
	docker build -t csharp-docker-practice .

run:
	docker run -d -p 5000:5000 csharp-docker-practice