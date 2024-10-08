using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 魂玉兑换回复 message
 */
public class ResSoulExchangeMessage : Message
{
    //0：兑换环，1：兑换体力
    int _type;
    //兑换得到的数量
    int _count;
    //兑换倍数
    int _ratio;

    /**
     * 序列化
     */
    public override void Serialize(Stream stream)
    {
        //0：兑换环，1：兑换体力
        SerializeUtils.WriteInt(stream, _type);
        //兑换得到的数量
        SerializeUtils.WriteInt(stream, _count);
        //兑换倍数
        SerializeUtils.WriteInt(stream, _ratio);
    }

    /**
     * 反序列化
     */
    public override void Deserialize(Stream stream)
    {
        //0：兑换环，1：兑换体力
        _type = SerializeUtils.ReadInt(stream);
        //兑换得到的数量
        _count = SerializeUtils.ReadInt(stream);
        //兑换倍数
        _ratio = SerializeUtils.ReadInt(stream);
    }

    /**
     * 0：兑换环，1：兑换体力
     */
    public int Type
    {
        set { _type = value; }
        get { return _type; }
    }

    /**
     * 兑换得到的数量
     */
    public int Count
    {
        set { _count = value; }
        get { return _count; }
    }

    /**
     * 兑换倍数
     */
    public int Ratio
    {
        set { _ratio = value; }
        get { return _ratio; }
    }


    public override int GetId()
    {
        return 207102;
    }
}