using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 特训箱子信息
 */
public class BoxInfo : IMessageSerialize 
{
	//位置(0到8)
	int _index;	
	//1:炸弹,2:倍数,3:随机等级
	int _type;	
	//值
	int _val;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//位置(0到8)
		SerializeUtils.WriteInt(stream, _index);
		//1:炸弹,2:倍数,3:随机等级
		SerializeUtils.WriteInt(stream, _type);
		//值
		SerializeUtils.WriteInt(stream, _val);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//位置(0到8)
		_index = SerializeUtils.ReadInt(stream);
		//1:炸弹,2:倍数,3:随机等级
		_type = SerializeUtils.ReadInt(stream);
		//值
		_val = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 位置(0到8)
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 1:炸弹,2:倍数,3:随机等级
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 值
	 */
	public int Val
	{
		set { _val = value; }
	    get { return _val; }
	}
	
}