cmake_minimum_required (VERSION 3.1)
project (coding-kata)

find_package(Threads REQUIRED)

# Require c++11.
set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

set(COMMON_INCLUDES ${PROJECT_SOURCE_DIR}/src)

##############
# External Library
##############

add_subdirectory(${PROJECT_SOURCE_DIR}/external/gtest)

# Include the gtest library.
include_directories(
  ${gtest_SOURCE_DIR}/include
  ${gtest_SOURCE_DIR}
)

##############
# Executables
##############

file(GLOB SRC_FILES ${PROJECT_SOURCE_DIR}/src/*.cpp)
# add_executable(${PROJECT_NAME} ${SRC_FILES})

##############
# Unit Tests
##############

set(PROJECT_TEST_NAME ${PROJECT_NAME}-tests)
include_directories(${GTEST_INCLUDE_DIRS} ${GMOCK_INCLUDE_DIRS} ${COMMON_INCLUDES})
file(GLOB TEST_SRC_FILES ${PROJECT_SOURCE_DIR}/test/*.cpp)
add_executable(${PROJECT_TEST_NAME} ${TEST_SRC_FILES} ${SRC_FILES})
add_dependencies(${PROJECT_TEST_NAME} googletest)

target_link_libraries(${PROJECT_TEST_NAME}
    ${GTEST_LIBS_DIR}/libgtest.a
    ${GTEST_LIBS_DIR}/libgtest_main.a
    ${GTEST_LIBS_DIR}/libgmock.a
    ${GTEST_LIBS_DIR}/libgmock_main.a
    ${CMAKE_THREAD_LIBS_INIT}
    )
