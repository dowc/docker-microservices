package main

import (
	"fmt"
	"net/http"
	"os"
	"log"
)

func handler(w http.ResponseWriter, r *http.Request) {
	var hostname string
	hostname, err := os.Hostname()
	if err != nil {
		log.Fatal(err)
	}
		
	fmt.Fprintf(w, "Hello world from Go app! container id = %s\n", hostname)
}

func main() {
	http.HandleFunc("/", handler)
	http.ListenAndServe(":3003", nil)
}
