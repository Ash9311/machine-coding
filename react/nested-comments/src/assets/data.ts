export const commentsData = [
    {
        id: 1,
        text: "This is the first comment",
        author: "User1",
        replies: [
            {
                id: 2,
                text: "This is a reply to the first comment",
                author: "User2",
                replies: [
                    {
                        id: 3,
                        text: "This is a nested reply",
                        author: "User3",
                        replies: []
                    }
                ]
            }
        ]
    },
    {
        id: 4,
        text: "This is another top-level comment",
        author: "User4",
        replies: []
    }
];
