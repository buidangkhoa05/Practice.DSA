package main

import "golang/model"

func isSameTree(p *model.TreeNode, q *model.TreeNode) bool {
	if p == nil && q == nil {
		return true
	} else if p == nil || q == nil {
		return false
	}

	if p.Val != q.Val {
		return false
	}

	return true && isSameTree(p.Left, q.Left) && isSameTree(p.Right, q.Right)
}
