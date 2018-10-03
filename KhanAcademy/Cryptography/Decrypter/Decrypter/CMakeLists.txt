cmake_minimum_required(VERSION 2.6)
project(decrypter)

add_executable(decrypter main.cpp)

install(TARGETS decrypter RUNTIME DESTINATION bin)
