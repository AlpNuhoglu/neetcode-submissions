func dailyTemperatures(temperatures []int) []int {

    length := len(temperatures)

    result := make([]int, length)  
    stack := make([]int, 0, length)

    for i := 0; i < length; i++ {
        for len(stack) > 0 && temperatures[i] > temperatures[stack[len(stack) - 1]] {

            topIndex := stack[len(stack) - 1]

            stack = stack[:len(stack) - 1]

            result[topIndex] = i - topIndex
        }

        stack = append(stack, i)
    }

    return result

}
